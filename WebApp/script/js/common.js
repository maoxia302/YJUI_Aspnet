$(function(){
	$("select").css("color", "#ADADAD");
	$("select").change(function() {
		if($(this).val()==""){
			$(this).css("color", "#ADADAD");
		}else{
			$(this).css("color", "#343434");
		}
	});
	$("body").append('<div class="errorTop"><em class="iconfont">&#xe60e;</em><label></label></div>');//提示弹层
	$("body").append('<div class="loading_container"><div class="line_loader"><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div></div></div>');
});
function alertWrong(msg,func) {
	$(".errorTop").fadeIn();
	$(".errorTop em").html("&#xe60e;");
	$(".errorTop label").html(msg);
	if(typeof(func)=="function"){
		setTimeout(function() {
			$(".errorTop").fadeOut();
			func.call();
		}, 2200);
	}else{
		setTimeout(function() {
			$(".errorTop").fadeOut();
		}, 2200);
	}
}

function alertRight(msg) {
	$(".errorTop").fadeIn();
	$(".errorTop em").html("&#xe603;");
	$(".errorTop label").html(msg);
	setTimeout(function() {
		$(".errorTop").fadeOut();
	}, 2200);
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



    ////获取url中的参数
    //function getUrlParam(name) {
    //    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
    //    var r = window.location.search.substr(1).match(reg);  //匹配目标参数
    //    if (r != null) return unescape(r[2]); return null; //返回参数值
    //}
})(jQuery);




