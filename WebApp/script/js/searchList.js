var pages = 1;
var total = 0;
$(function () {

    toSearch(pages);
	//查询弹层显示
	$(".toSearch").click(function(){
		$(".topMask").fadeIn();
		$(".search_dialog").slideDown();
	});
	
	//查询弹层隐藏
	$(".searchClose,.topMask").click(function(){
		$(".topMask").fadeOut();
		$(".search_dialog").slideUp();
	});
	
	//时间插件
	var now = new Date();
	var optDate = {
		preset: 'date', //日期   
		theme: 'android-ics light', //皮肤样式   
		display: 'modal', //显示方式    
		mode: 'scroller', //日期选择模式   
		lang: 'zh',
		showNow: false,
		//minDate: new Date(now.getFullYear(), now.getMonth(), (now.getDate()+1)), 
		maxDate: new Date(now.getFullYear(), now.getMonth(), now.getDate()),
	};
	$("#start,#end").mobiscroll(optDate);
	
	//点击查询
	$(".searchBtn").click(function(){
		
		$(".topMask").fadeOut();
		$(".search_dialog").slideUp();
	});
	
	$(".operation").click(function(e){
		$(this).parent().find(".search_opt").slideToggle();
		e.stopPropagation();
	});
	$(document).click(function(){
		$(".search_opt").hide();
	});

    
	$(window).scroll(function() {  
      //当内容滚动到底部时加载新的内容  
      if ($(this).scrollTop() + $(window).height() + 20 >= $(document).height() && $(this).scrollTop() > 20) {  
          //alert("哦哦,到底了.");
          pages++;
          if (pages <= Math.ceil(total / 5)) {
              toSearch(pages);
          }
          
      }  
    });


    $('#search').click(function () {
        var start = $.getUrlParam("start");
        console.log(start);
        var end = $.getUrlParam("end");
        var fk_person = $.getUrlParam("fk_person");
        var fk_type = $.getUrlParam("fk_type");
        $("#searchList").empty();
        var data = {
            //bdate: start,
            //edate: end,
            //fkPerson: fk_person,
            //fkType: fk_type
        };
        $.ajax({
            url: "/ashx/ui_neibutaizhang.ashx?action=search",
            data: data,
            async: false,
            success: function (data) {
                console.log(data);
            }
        });
    });
	
});

function toSearch(page) {
    
    var start = $.getUrlParam("start");
    var end = $.getUrlParam("end");

    var fk_person = $.getUrlParam("fk_person");
    var fk_type = $.getUrlParam("fk_type");
    $("#searchList").empty();
    var data = {
        bdate: start,
        edate: end,
        fkPerson: fk_person,
        fkType: fk_type,
        page: page
    };
    $.ajax({
        url: "/ashx/ui_neibutaizhang.ashx?action=search",
        data: data,
        async: false,
        success: function (data) {
            var liHtml = '';
            data = JSON.parse(data);
            for (var i = 0; i < data.rows.length; i++) {
                liHtml = liHtml + '<li><h2 class="clearfix" >标题一<div class="searchList_right" ><div class="searchList_select"><span class="operation">操作<em></em></span><ul class="search_opt">';
                liHtml = liHtml + '<li><a href="investigate.html?id=' + data.rows[i].ID + '">问题处理&ensp;&gt;</a></li><li><a href="support.html">落实检核&ensp;&gt;</a></li><li><a href="custFeedback.html">满意度评价&ensp;&gt;</a></li><li><a href="custFeedback.html">第三方检核&ensp;&gt;</a></li></ul></div></div></h2>';
                liHtml = liHtml + '<label>反&ensp;馈&ensp;人：</label>' + data.rows[i].fkPerson + ' <label></br >反馈时间：</label>' + data.rows[i].fkDate + '</br ><label>反馈部门：</label>' + data.rows[i].fkDep + '</br >';
                liHtml = liHtml + '<label>反馈地区：</label>' + data.rows[i].fkArea + ' <label></br >反馈客户：</label>' + data.rows[i].fkCustomer + '</br ><label>问题类型：</label>' + data.rows[i].fkCustomer + '</br >'; 
                liHtml = liHtml + '<label style="display:inline-block;width:24%;vertical-align: top;">反馈描述：</label><span style="display:inline-block;width:76%;vertical-align: top;">' + data.rows[i].fkDesc + '</span></br ><label>领取部门：</label>' + data.rows[i].dyDep + '</br ><label>第一责任人：</label>' + data.rows[i].dyPerson + '</br >';
                liHtml = liHtml + '<label>接收问题时间：</label>' + data.rows[i].dyDate + '</br ><label>临时改善：</label>' + data.rows[i].dyGaishan + '</br ><label>长期方案：</label>' + data.rows[i].cqFangan + ' </br ><label>长期时间：</label>' + data.rows[i].cqDate + '</br >';       
                liHtml = liHtml + '<label>落实检核：</label>' + data.rows[i].lsJianhe + ' </br ><label>落实部门：</label>' + data.rows[i].lsDep + '</br ><label>落实时间：</label>' + data.rows[i].lsDate + '</br >';         
                liHtml = liHtml + '<label>满意度评价：</label>' + data.rows[i].myPingjia + ' </br ><label>满意人：</label>' + data.rows[i].myPerson + '</br ><label>满意时间：</label>' + data.rows[i].myDate + '</br >';  
                liHtml = liHtml + '<label>满意度评价：</label>' + data.rows[i].myPingjia + ' </br ><label>满意人：</label>' + data.rows[i].myPerson + '</br ><label>满意时间：</label>' + data.rows[i].myDate + '</li >';   
            }
            if (page == 1) {
                total = data.total;
            }
            $("#searchList").append(liHtml);
        }
    });
}
