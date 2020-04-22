$(function() {
    initLogin();
    InitLeftMenu();
    tabClose();
    tabCloseEven();
});

//初始化左侧
function InitLeftMenu() {
    $.ajax({
        url: "../ashx_ui/ui_leftmenu.ashx",
        type: "POST",
        dataType: "json",
        success: function(_menus) {

            $("#westreg").empty();
            var menulist = "";
            menulist += '<div class="easyui-accordion" fit="true" border="false">';
            $.each(_menus.menus, function(i, n) {
                menulist += '<div title="' + n.menuname + '" data-options="iconCls:\'' + n.icon + '\'" style="overflow: auto; padding: 5px;">';
                menulist += '<ul>';
                $.each(n.menus, function(j, o) {
                    menulist += '<li><div><a href="###" rel="' + o.url + '" ref="' + o.menuid + '"><span class="' + o.icon + '" style="width: 16px; display: inline-block">&nbsp;</span><span class="nav">' + o.menuname + '</span></a></div></li>';
                })
                menulist += '</ul></div>';
            })
            menulist += '</div>';
            $("#westreg").append(menulist);

            $('.easyui-accordion li a').click(function() {
                var tabTitle = $(this).children('.nav').text();

                var url = $(this).attr("rel");
                var menuid = $(this).attr("ref");
                var icon = $(this).children('span').first().attr('class');
                var id = tabTitle;
                addTab(tabTitle, url, icon,id);
                $('.easyui-accordion li div').removeClass("selected");
                $(this).parent().addClass("selected");
            }).hover(function() {
                $(this).parent().addClass("hover");
            }, function() {
                $(this).parent().removeClass("hover");
            });

            //导航菜单绑定初始化
            $(".easyui-accordion").accordion();
        },
        error: function(xhr, status) {
            if (xhr.responseText == "nosession") {
                $.relogin();
            }
        }
    });

}

/* 请求Ajax 带返回值
--------------------------------------------------*/
function getAjax(url, parm, callBack) {
    $.ajax({
        type: 'post',
        dataType: "text",
        url: url,
        data: parm,
        cache: false,
        async: false,
        success: function (msg) {
            callBack(msg);
        }
    });
}

//自动获取页面控件值
function GetWebControls(element) {
    var reVal = "";
    $(element).find('input,select,textarea').each(function (r) {
        var id = $(this).attr('id');
        var value = $(this).val();
        var type = $(this).attr('type');
        switch (type) {
            case "checkbox":
                if ($(this).is(':checked')) {
                    reVal += '"' + id + '"' + ':' + '"1",';
                } else {
                    reVal += '"' + id + '"' + ':' + '"0",';
                }
                break;
            default:
                reVal += '"' + id + '"' + ':' + '"' + $.trim(value) + '",';
                break;
        }
    });
}

function initLogin() {
    getSession(function f(r) {
        try {
            var user = $.parseJSON(r);
            if (user.id) {
                $("#div_welcom").html(user.xingming + "，欢迎您！");
                $("#hd_account").val(user.account);
            } else {
                $.relogin();
            }
        } catch (e) {
        }

    });
}

function addTab(subtitle, url, icon,id) {
    if (!$('#tabs').tabs('exists', subtitle)) {
        $('#tabs').tabs('add', {
            title: subtitle,
            //  : createFrame(url),
            id:id,
            href: url,
            closable: true,
            icon: icon,
            loadingMessage: '正在加载中......'

        });
       
    } else {
        $('#tabs').tabs('select', subtitle);
    }
    tabClose();
}

function addTab_new(title, url) {
    if ($('#tabs').tabs('exists', title)) {
        $('#tabs').tabs('select', title);
    } else {
        var content = '<iframe scrolling="no" frameborder="0"  src="' + url + '" style="width:100%;height:99%;margin:0;padding:0"></iframe>';
        $('#tabs').tabs('add', {
            title: title,
            content: content,
            closable: true
        });
    }
}



function addTab1(title, url, icon) {
    //关闭当前的
    var currTab = $('#tabs').tabs('getSelected');
    if (currTab) {
        $('#tabs').tabs('close', currTab.panel('options').title);
    }
    if ($('#tabs').tabs('exists', title)) {
        $('#tabs').tabs('select', title);//选中并刷新
        var currTab = $('#tabs').tabs('getSelected');
        var url = $(currTab.panel('options').content).attr('src');
        if (url != undefined && currTab.panel('options').title != 'Home') {
            $('#tabs').tabs('update', {
                tab: currTab,
                options: {
                    content: createFrame(url)
                }
            })
        }
    } else {
        var content = createFrame(url);
        $('#tabs').tabs('add', {
            title: title,
            content: content//,
            //closable:true
        });
    }
    tabClose();
}




function createFrame(url) {
    var s = '<iframe scrolling="auto" frameborder="0"  src="' + url + '" style="width:100%;height:100%;"></iframe>';
    return s;
}

function tabClose() {
    /*双击关闭TAB选项卡*/
    $(".tabs-inner").dblclick(function () {
        var subtitle = $(this).children(".tabs-closable").text();
        $('#tabs').tabs('close', subtitle);
    })
    /*为选项卡绑定右键*/
    $(".tabs-inner").bind('contextmenu', function (e) {
        $('#mm').menu('show', {
            left: e.pageX,
            top: e.pageY
        });

        var subtitle = $(this).children(".tabs-closable").text();

        $('#mm').data("currtab", subtitle);
        $('#tabs').tabs('select', subtitle);
        return false;
    });
}
//绑定右键菜单事件
function tabCloseEven() {
    //关闭当前
    $('#mm-tabclose').click(function () {
        var currtab_title = $('#mm').data("currtab");
        $('#tabs').tabs('close', currtab_title);
    })
    //全部关闭
    $('#mm-tabcloseall').click(function () {
        $('.tabs-inner span').each(function (i, n) {
            var t = $(n).text();
            $('#tabs').tabs('close', t);
        });
    });
    //关闭除当前之外的TAB
    $('#mm-tabcloseother').click(function () {
        var currtab_title = $('#mm').data("currtab");
        $('.tabs-inner span').each(function (i, n) {
            var t = $(n).text();
            if (t != currtab_title)
                $('#tabs').tabs('close', t);
        });
    });
    //关闭当前右侧的TAB
    $('#mm-tabcloseright').click(function () {
        var nextall = $('.tabs-selected').nextAll();
        if (nextall.length == 0) {
            //msgShow('系统提示','后边没有啦~~','error');
            //  alert('后边没有啦~~');
            return false;
        }
        nextall.each(function (i, n) {
            var t = $('a:eq(0) span', $(n)).text();
            $('#tabs').tabs('close', t);
        });
        return false;
    });
    //关闭当前左侧的TAB
    $('#mm-tabcloseleft').click(function () {
        var prevall = $('.tabs-selected').prevAll();
        if (prevall.length == 0) {
            // alert('到头了，前边没有啦~~');
            return false;
        }
        prevall.each(function (i, n) {
            var t = $('a:eq(0) span', $(n)).text();
            $('#tabs').tabs('close', t);
        });
        return false;
    });

    //退出
    $("#mm-exit").click(function() {
        $('#mm').menu('hide');
    });
}

function refreshTab() {
    var index = $('#tabs').tabs('getTabIndex', $('#tabs').tabs('getSelected'));
    $('#tabs').tabs('getTab', index).panel('refresh');
}

function closeTab() {
    var index = $('#tabs').tabs('getTabIndex', $('#tabs').tabs('getSelected'));
    $('#tabs').tabs('close', index);
}
function loginout() {
    $.messager.confirm('提示！', '确定退出系统？', function(r) {
        if (r) {
            try {
                var para = { "action": "loginout" };
                $.ajax({
                    url: "/ashx_ui/login.ashx",
                    type: "post",
                    data: para,
                    success: function(r) {
                        window.location.href = "login.htm";
                    }
                });
            } catch (e) {
            }
        }
    });
}
///几位补零操作
function PrefixInteger(num, length) {
    return (Array(length).join('0') + num).slice(-length);
}



(function ($) {
    $.fn.serializeObject = function () {
        var o = {};
        var a = this.serializeArray();
        $.each(a, function () {
            if (o[this.name]) {
                if (!o[this.name].push) {
                    o[this.name] = [o[this.name]];
                }
                o[this.name].push(this.value || '');
            } else {
                o[this.name] = this.value || '';
            }
        });
        console.log(o)
        return o;
    }
})(jQuery);

//自动给控件赋值
function SetWebControls(data) {
    for (var key in data) {
        var id = $('#' + key);
        var value = $.trim(data[key]).replace("&nbsp;", "");
        var type = id.attr('type');
        switch (type) {
            case "checkbox":
                if (value == 1) {
                    id.attr("checked", 'checked');
                } else {
                    id.removeAttr("checked");
                }
                break;
            default:
                id.val(value);
                break;
        }
    }
}
