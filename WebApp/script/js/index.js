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
    //maxDate: new Date(now.getFullYear(), now.getMonth(), now.getDate()),
};
$("#start,#end").mobiscroll(optDate);

$(function () {
    $('#search').click(function () {
        var data = $("#ff").serializeObject();
        console.log(data);
        //debugger;
        if (data != null) {
            window.location.href = "searchList.html?start=" + data.start + "&end=" + data.end + "&fkPerson=" + data.fk_person + "&fk_type=" + data.fk_type;
            //window.location.href = "searchList.html?data=" + JSON.stringify(data);
        }
       

    });


    $.ajax({
        url: "/ashx/ui_guzhang.ashx?action=getItem",
        type: "get",
        success: function (data) {
            data = JSON.parse(data);
            $("#fk_type").empty();
            $("#fk_type").append('<option value="">请选择类型</option>');
            $.each(data, function (i) {
                $("#fk_type").append($("<option></option>").val(data[i].guzhang).html(data[i].guzhang));
            });
        },
        error: function () { }
    });


    $('#add_info').click(function () {
        window.location.href = "issueType.html";


    });






});