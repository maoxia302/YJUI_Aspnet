/** 
* panel关闭时回收内存，主要用于layout使用iframe嵌入网页时的内存泄漏问题
*/
$.fn.panel.defaults.onBeforeDestroy = function () {
    var frame = $('iframe', this);
    try {
        // alert('销毁，清理内存');
        if (frame.length > 0) {
            for (var i = 0; i < frame.length; i++) {
                frame[i].contentWindow.document.write('');
                frame[i].contentWindow.close();
            }
            frame.remove();
            if ($.browser.msie) {
                CollectGarbage();
            }
        }
    } catch (e) {
    }
};
/** 
* 在iframe中调用，在父窗口中出提示框(herf方式不用调父窗口)
*/
$.extend({ show_warning: function (strTitle, strMsg) {
    $.messager.show({
        title: strTitle,
        msg: strMsg,
        showType: 'slide',
        style: {
            right: '',
            top: document.body.scrollTop + document.documentElement.scrollTop,
            bottom: ''
        }
    });
}
});
$.extend({ show_alert: function (strTitle, strMsg) {
    $.messager.alert(strTitle, strMsg);
}
});


/**
* @author 孙宇
* 
* @requires jQuery,EasyUI
* 
* 防止panel/window/dialog组件超出浏览器边界
* @param left
* @param top
*/

var easyuiPanelOnMove = function (left, top) {
    var l = left;
    var t = top;
    if (l < 1) {
        l = 1;
    }
    if (t < 1) {
        t = 1;
    }
    var width = parseInt($(this).parent().css('width')) + 14;
    var height = parseInt($(this).parent().css('height')) + 14;
    var right = l + width;
    var buttom = t + height;
    var browserWidth = $(window).width();
    var browserHeight = $(window).height();
    if (right > browserWidth) {
        l = browserWidth - width;
    }
    if (buttom > browserHeight) {
        t = browserHeight - height;
    }
    $(this).parent().css({/* 修正面板位置 */
        left: l,
        top: t
    });
};
$.fn.dialog.defaults.onMove = easyuiPanelOnMove;
$.fn.window.defaults.onMove = easyuiPanelOnMove;
$.fn.panel.defaults.onMove = easyuiPanelOnMove;


/**
* @author 夏悸
* 
* @requires jQuery,EasyUI
* 
* 扩展tree，使其支持平滑数据格式
*/
$.fn.tree.defaults.loadFilter = function (data, parent) {
    var opt = $(this).data().tree.options;
    var idFiled, textFiled, parentField;
    //alert(opt.parentField);
    if (opt.parentField) {
        idFiled = opt.idFiled || 'id';
        textFiled = opt.textFiled || 'text';
        parentField = opt.parentField;
        var i, l, treeData = [], tmpMap = [];
        for (i = 0, l = data.length; i < l; i++) {
            tmpMap[data[i][idFiled]] = data[i];
        }
        for (i = 0, l = data.length; i < l; i++) {
            if (tmpMap[data[i][parentField]] && data[i][idFiled] != data[i][parentField]) {
                if (!tmpMap[data[i][parentField]]['children'])
                    tmpMap[data[i][parentField]]['children'] = [];
                data[i]['text'] = data[i][textFiled];
                tmpMap[data[i][parentField]]['children'].push(data[i]);
            } else {
                data[i]['text'] = data[i][textFiled];
                treeData.push(data[i]);
            }
        }
        return treeData;
    }
    return data;
};
/**
* @author 孙宇
* 
* @requires jQuery,EasyUI
* 
* 扩展combotree，使其支持平滑数据格式
*/
$.fn.combotree.defaults.loadFilter = $.fn.tree.defaults.loadFilter;

/**
* @author 孙宇
* 
* @requires jQuery,EasyUI
* 
* 通用错误提示
* 
* 用于datagrid/treegrid/tree/combogrid/combobox/form加载数据出错时的操作/combotree
*/
var easyuiErrorFunction = function (XMLHttpRequest) {
    $.messager.progress('close');
    // $.messager.alert('错误', XMLHttpRequest.responseText);
    if (XMLHttpRequest.responseText == "nosession") {    //未登录
        $.relogin();
    }
    else {
        window.parent.window.$.messager.alert('错误', XMLHttpRequest.responseText);
    }
};
$.fn.datagrid.defaults.onLoadError = easyuiErrorFunction;
$.fn.treegrid.defaults.onLoadError = easyuiErrorFunction;
$.fn.tree.defaults.onLoadError = easyuiErrorFunction;
$.fn.combogrid.defaults.onLoadError = easyuiErrorFunction;
$.fn.combobox.defaults.onLoadError = easyuiErrorFunction;
$.fn.form.defaults.onLoadError = easyuiErrorFunction;
$.fn.combotree.defaults.onLoadError = easyuiErrorFunction;

/**
* @author 孙宇
* 
* @requires jQuery,EasyUI
* 
* 扩展validatebox，添加验证两次密码功能
*/
$.extend($.fn.validatebox.defaults.rules, {
    eqPwd: {
        validator: function (value, param) {
            return value == $(param[0]).val();
        },
        message: '密码不一致！'
    }
});

/*
*@zf
*用户未登录 或session超时 弹出登录框重新登录
*/
$.extend({ relogin: function () {

        $("<div/>").attr("id", "dialog_relogin").dialog({
            title: " 未登录或登录超时，请重新登录",
            href: "/htm_ui/ui_relogin.htm",
            width: 300,
            height: 200,
            closable: false,
            iconCls: "icon-lock",
            modal: true,
            buttons: [
                {
                    text: "登录",
                    iconCls: "icon-key",
                    handler: function() {
                        var para = {};
                        para.uname = $("#relogin_account").val();
                        para.pwd = $("#relogin_pwd").val();
                        para.action = "login";
                        para.timespan = new Date().getTime();
                        $.ajax({
                            url: "/ashx_ui/login.ashx",
                            type: "POST",
                            data: para,
                            dataType: "text",
                            success: function(result) {
                                if (result == "ok") {
                                    $.show_warning("提示", "登录成功");
                                    $("#dialog_relogin").dialog('destroy');
                                } else {
                                    $.show_alert("错误", result);
                                }
                            }
                        });
                    }

                },
                {
                    text: "退出系统",
                    iconCls: "icon-cancel",
                    handler: function() {
                        window.parent.location.href = "/login.htm";
                    }
                }
            ]
        });
    }
});
/*
*zf
*获取session
*/
function getSession(deal) {
    $.ajax({
        url: "/ashx_ui/getsession.ashx",
        type: "POST",
        success: function(r) { deal(r); }
    });
}
function getSession1() {

    $.ajax({
        url: "/ashx_ui/getsession.ashx",
        type: "POST",
        success: function (r) {
        }
    });
}
/*
*     zf
*     处理ajax返回值通用处理方法 
*     
*/
function dealAjaxResult(result, okFun) {
    if (result == "nosession") {
        $.relogin();
    }
    else if (result == "ok") {
        okFun(result);
    }
    else if (result == "err") {
        $.show_alert("错误", result);
    } else if (result == "no") {
        $.show_alert("错误", "当前改步骤不能操作");
    }
}


$.extend($.fn.datagrid.defaults.editors, {
    textarea: {
        init: function (container, options) {
            var input = $('<textarea class="datagrid-editable-input" rows=' + options.rows + '></textarea>').appendTo(container);
            return input;
        },
        getValue: function (target) {
            return $(target).val();
        },
        setValue: function (target, value) {
            $(target).val(value);
        },
        resize: function (target, width) {
            var input = $(target);
            if ($.boxModel == true) {
                input.width(width - (input.outerWidth() - input.width()));
            } else {
                input.width(width);
            }
        }
    }
}); 

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

//判断是否为空
function isEmpty(target) {
    if (target == null || target == "null" || target == "" || target == "undefined" || target == undefined) {
        return true;
    }
    return false;
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

(function ($) {
    $.getUrlParam = function (name) {
        var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
        var r = window.location.search.substr(1).match(reg);
        if (r != null)
            return decodeURI(r[2]); // decodeURI(r[2]); 解决参数是中文时的乱码问题

        return null;
    }
})(jQuery);

//'20200101'变成'2020-01-01'公共方法
(function ($) {
    $.strDate = function (riqi) {
        return riqi.replace(/(\d{4})(\d{2})(\d{2})/g, '$1-$2-$3');
    }
})(jQuery);



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

function addTab_new02(title, url) {
    if (window.parent.$('#tabs').tabs('exists', title)) {
        window.parent.$('#tabs').tabs('select', title);
    } else {
        var content = '<iframe scrolling="no" frameborder="0"  src="' + url + '" style="width:100%;height:99%;margin:0;padding:0"></iframe>';
        window.parent.$('#tabs').tabs('add', {
            title: title,
            content: content,
            closable: true
        });
    }
}

/*
 *   功能:实现VBScript的DateAdd功能.
 *   参数:interval,字符串表达式，表示要添加的时间间隔.
 *   参数:number,数值表达式，表示要添加的时间间隔的个数.
 *   参数:date,时间对象.
 *   返回:新的时间对象.
 *   var now = new Date();
 *   var newDate = DateAdd( "d", 5, now);
 *---------------   DateAdd(interval,number,date)   -----------------
 */
function DateAdd(interval, number, date) {
    switch (interval) {
        case "y ": {
            date.setFullYear(date.getFullYear() + number);
            return date;
            break;
        }
        case "q ": {
            date.setMonth(date.getMonth() + number * 3);
            return date;
            break;
        }
        case "m ": {
            date.setMonth(date.getMonth() + number);
            return date;
            break;
        }
        case "w ": {
            date.setDate(date.getDate() + number * 7);
            return date;
            break;
        }
        case "d ": {
            date.setDate(date.getDate() + number);
            return date;
            break;
        }
        case "h ": {
            date.setHours(date.getHours() + number);
            return date;
            break;
        }
        case "m ": {
            date.setMinutes(date.getMinutes() + number);
            return date;
            break;
        }
        case "s ": {
            date.setSeconds(date.getSeconds() + number);
            return date;
            break;
        }
        default: {
            date.setDate(d.getDate() + number);
            return date;
            break;
        }
    }
}

//var now = new Date();
//// 加五天.
//var newDate = DateAdd("d ", 5, now);
//alert(newDate.toLocaleDateString())
//// 加两个月.
//newDate = DateAdd("m ", 2, now);
//alert(newDate.toLocaleDateString())
//// 加一年
//newDate = DateAdd("y ", 1, now);
//alert(newDate.toLocaleDateString())



/*
* 获得时间差,时间格式为 年-月-日 小时:分钟:秒 或者 年/月/日 小时：分钟：秒
* 其中，年月日为全格式，例如 ： 2010-10-12 01:00:00
* 返回精度为：秒，分，小时，天
* //调用格式var result = GetDateDiff("2010-02-26 16:00:00", testStr, "day");
*/

function GetDateDiff(startTime, endTime, diffType) {
    //将xxxx-xx-xx的时间格式，转换为 xxxx/xx/xx的格式 
    startTime = startTime.replace(/\-/g, "/");
    endTime = endTime.replace(/\-/g, "/");

    //将计算间隔类性字符转换为小写
    diffType = diffType.toLowerCase();
    var sTime = new Date(startTime);      //开始时间
    var eTime = new Date(endTime);  //结束时间
    //作为除数的数字
    var divNum = 1;
    switch (diffType) {
        case "second":
            divNum = 1000;
            break;
        case "minute":
            divNum = 1000 * 60;
            break;
        case "hour":
            divNum = 1000 * 3600;
            break;
        case "day":
            divNum = 1000 * 3600 * 24;
            break;
        default:
            break;
    }
    return parseInt((eTime.getTime() - sTime.getTime()) / parseInt(divNum));
}


//时间格式化问题
Date.prototype.Format = function (fmt) {
    var o = {
        "M+": this.getMonth() + 1, //月份   
        "d+": this.getDate(), //日   
        "H+": this.getHours(), //小时   
        "m+": this.getMinutes(), //分   
        "s+": this.getSeconds(), //秒   
        "q+": Math.floor((this.getMonth() + 3) / 3), //季度   
        "S": this.getMilliseconds() //毫秒   
    };
    if (/(y+)/.test(fmt)) fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var k in o)
        if (new RegExp("(" + k + ")").test(fmt)) fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
    return fmt;
} 


//js时间格式化方法
function dateFormat(fmt, date) {
    let ret;
    let opt = {
        "Y+": date.getFullYear().toString(),        // 年
        "m+": (date.getMonth() + 1).toString(),     // 月
        "d+": date.getDate().toString(),            // 日
        "H+": date.getHours().toString(),           // 时
        "M+": date.getMinutes().toString(),         // 分
        "S+": date.getSeconds().toString()          // 秒
    };
    for (let k in opt) {
        ret = new RegExp("(" + k + ")").exec(fmt);
        if (ret) {
            fmt = fmt.replace(ret[1], (ret[1].length == 1) ? (opt[k]) : (opt[k].padStart(ret[1].length, "0")))
        };
    };
    return fmt;
}
//let date = new Date();
////let time = dateFormat("YYYY-mm-dd HH:MM:SS", date);
//console.log(time);



//获取当前时间（年月日时分秒）
function getNowDate() {
    var nowDate = new Date;
    var y = nowDate.getFullYear()
    var m = nowDate.getMonth() + 1
    m = m < 10 ? '0' + m : m
    var d = nowDate.getDate()
    d = d < 10 ? ('0' + d) : d
    var hour = nowDate.getHours();
    hour = hour < 10 ? '0' + hour : hour
    var minute = nowDate.getMinutes();
    minute = minute < 10 ? '0' + minute : minute
    var second = nowDate.getSeconds();
    second = second < 10 ? '0' + second : second
    var curDate = y + '-' + m + '-' + d + ' ' + hour + ':' + minute + ':' + second;
    return curDate;
}

(function ($) {
    $.getUrlParam = function (name) {
        var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
        var r = window.location.search.substr(1).match(reg);
        if (r != null)
            return decodeURI(r[2]); // decodeURI(r[2]); 解决参数是中文时的乱码问题

        return null;
    }



    ////获取url中的参数
    //function getUrlParam(name) {
    //    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
    //    var r = window.location.search.substr(1).match(reg);  //匹配目标参数
    //    if (r != null) return unescape(r[2]); return null; //返回参数值
    //}
})(jQuery);



