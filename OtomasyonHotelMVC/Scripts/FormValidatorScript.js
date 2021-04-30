$(function () {
    $("form[id='FrmRegion']").validate({
        rules: {
            RegionCode:"required"
        },
        messages: {
            RegionCode:"Hatavar Reis"
        },
        submitHander: function (form) {
            form.submit();
        }
    })
})




//$(function () {
//    var $Form = $("#FrmRegion");
//    if ($Form.length) {
//        $Form.validate({
//            rules: {
//                RegionCode: {
//                    required: true,


//                }
//            },
//            messages: {
//                RegionCode: {
//                    required: "Boş bırakma Lütfen pls"
//                }
//            }
//        })
//    }

//})