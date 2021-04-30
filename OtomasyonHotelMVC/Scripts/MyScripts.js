$(function () {
    $("form[name='registration']").validate({
        rules: {
            firstname: "required",
            lastname: "required",

        },
        messages: {
            firstname: "reg Boş bırakma",
            lastname: "name Boş bırakma",

        },
        submitHander: function (form) {
            form.submit();
        }
    });
});

var IslemSonucKodlari =
{
    Basarili: 1,
    Hata: 2,
    Uyari: 3,
    Bilgi: 4
};
var IslemSonucTurleri =
{
    Basarili: "BASARILI",
    Hata: "HATA",
    Uyari: "UYARI",
    Bilgi: "BILGI"
};
function MesajKapat() {
    $("#DivSonuc").removeClass();
    $("#DivSonuc").children("strong").text("");
    $("#DivSonuc").children("p").text("");
    //$("#DivSonuc").css({ "display": "none" });
    $("#DivSonuc").hide();
}
function FormGoster(url, modelId) {

    $("#" + modelId).children().children().children(".modal-body").empty();
    $("#" + modelId).children().children().children(".modal-body").load(url, function (data) {
        $("#" + modelId).show("modal");
    });
}
function FormGoster(url, modelId, callback) {
    $("#" + modelId).children().children().children(".modal-body").empty();
    $("#" + modelId).children().children().children(".modal-body").load(url, function (data) {
        $("#" + modelId).show("modal");
        //callback();
    });
}

function FormKapat(modelId) {
    $("#" + modelId).hide();
    $("#" + modelId).children().children().children(".modal-body").empty();

}
function ModalGoster(modalId) {
    $("#" + modalId).modal("show");
}
function ModalMessage(Message){

}

// HATA KODLARINI GÖSTERİYOR LİSTE OLARAK
function ModalBilgilendirme(header, Message) {
    
    $("#MdlBaslik").text(header);
        $("#MdlAciklama").text("");

    $.each(Message, function (key, value) {
            $("#MdlAciklama").append("<li style='color:blue'>"+value+"</li>");

    });
     //$("#MdlAciklama").text(Message);
    ModalGoster("MdlBilgilendirme");
}
function ModalBosBilgilendirme(header, Message) {

 
    $("#MdlAciklama").text(Message);
    ModalGoster("MdlBilgilendirme");
}

function ModalKapat(modalId) {
    $("#" + modalId).modal("hide");
}

    //$("document").ready(function () {
    //    $(function () {
    //        $("form[name='FrmRegion']").validate({
    //            rules: {
    //                RegionCode: "required",
    //                RegionName: "required",

    //            },
    //            messages: {
    //                RegionCode: "reg Boş bırakma",
    //                RegionName: "name Boş bırakma",

    //            },
    //            //submitHander: function (form) {
    //            //    form.submit();
    //            //}
    //        });
    //    });
    //});


function RegionSave() {
    if ($("#CountryId").val() === "" ) {
        ModalBosBilgilendirme("Uyarı", "Şehir Seçiniz");
        return false;
        var kontrol = document.getElementById("#RegionCode").value;
        if (kontrol === "") {
            alert("Hata Oluştu");
            return false;
        }
    }
    // TODO: MANUEL OLARAK KARAKTER SİNİRLAMASİ YAPİYOR OTOMATİK YAPMASİ LAZİM DÜZELTME YAPILACAK
    if ($("#RegionCode").val() === "") {
        ModalBosBilgilendirme("Uyarı", "Bölge Seçiniz");
        return false;
    }
    //if (sonuc > 3) {
    if ($("#RegionCode").val().length > 3) {
        ModalBosBilgilendirme("Uyarı", "Bölge Kodu 3 Karkteri Aşamaz");
        return false;
    }
    if ($("#RegionName").val() === "") {
        ModalBosBilgilendirme("Uyarı", "Bölgenin Adını Giriniz.");
        return false;
    } if ($("#RegionName").val().length > 100) {
        ModalBosBilgilendirme("Uyarı", "Bölge Adı 100 Karkteri Aşamaz");
        return false;
    }
    //$("#FrmRegion").validate();


    $.ajax({
        method: 'POST',
        url: '../Location/RegionJson',
        content: "application/json;",
        dataType: 'json',        
        data: $("#FrmRegion").serialize(),
        beforeSend: function () {

        }
    }).done(function (data) {
     
        if (data.IslemKodu === IslemSonucKodlari.Basarili) {
            
            ModalBilgilendirme("Bilgilendirme", data.Items);
            $("#RegionModal").hide();
            StokListele();
        }
        else if (data.IslemKodu === IslemSonucKodlari.Hata) {
            ModalBilgilendirme("Hata", data.Items);
        }
        //alert("Id:" + data.Data);
    }).fail(function () {
        console.log("Hata oluştu.");
        ModalBilgilendirme("Hata", "Hata Oluştu.");
    });
}