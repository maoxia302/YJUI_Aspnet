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
if (isEmpty(localStorage.getItem("params")))  {
    window.location.href = "../login.html";
}
var imgArr = [];//存放上传图片
$(function () {
    getItem();
    //点击”+“号，文件上传前
    $(document).on('change', '.upload_btn input', function () {
        var file = this.files;
        imgArr = [];
        for (var i = 0; i < file.length; i++) {
            var r = new FileReader();
            r.readAsDataURL(file[i]);
            $(r).load(function () {
                imgArr.push(this.result);
                $(".upload_btn").before('<span><img src="' + this.result + '" /><i class="iconfont" onclick="deletImg($(this))">&#xe60f;</i></span>');
                $(".index_upload>span").each(function () {
                    if (parseInt($(this).index() + 1) % 3 == 0 && parseInt($(this).index() + 1) != 0) {
                        $(this).css("margin-right", 0);
                    }
                });
            });
        }
        
    });
});

//删除图片
function deletImg(cur) {
    cur.parent().remove();
    $(".index_upload>span").each(function () {
        if (parseInt($(this).index() + 1) % 3 == 0 && parseInt($(this).index() + 1) != 0) {
            $(this).css("margin-right", 0);
        }
    });
}

function getItem() {
    $.ajax({
        url: "/ashx/ui_guzhang.ashx?action=getItem",
        type: "get",
        success: function (data) {
            //console.log(data)
            var msg = JSON.parse(data).msg;
            var selectData = JSON.parse(data).data;
            //if (msg != 'success') {
            //   window.location.href = "../login.html";
            //}
            $("#fk_type").empty();
            $("#fk_type").append('<option value="">请选择类型</option>');
            if (!isEmpty(selectData)) {
                $.each(selectData, function (i) {
                    //$("#fk_type").append($("<option></option>").val(selectData[i].guzhang).html(selectData[i].guzhang));
                    var option = $('<option value=' + selectData[i].guzhang + '>' + selectData[i].guzhang + '</option>');
                    $("#fk_type").append(option);
                });
            }
            
        },
        error: function () { }
    });



}



$('#add_info').click(function () {
    window.location.href = "issueType.html";


});

$('#search').click(function () {

    var data = $("#ff").serializeObject();
    console.log(data);
    //debugger;
    if (data != null) {
        window.location.href = "searchList.html?start=" + data.start + "&end=" + data.end + "&fkPerson=" + data.fk_person + "&fk_type=" + data.fk_type;
        //window.location.href = "searchList.html?data=" + JSON.stringify(data);
    }


});