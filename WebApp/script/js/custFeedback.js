$(function(){
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
	$("#fkDate").mobiscroll(optDate);
});
