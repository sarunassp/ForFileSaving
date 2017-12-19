function validate()
{
    var forma = document.forms["forma"];
    var vardas = forma["vardas"].value;
    var kortelesNumeris = forma["kortelesNumeris"].value;
    var data = forma["kortelesData"].value;

    if (vardas == "" || vardas == null) {
        alert("Please Fill All Required Field");
        return false;
    }
    if (Number.isInteger(Number(kortelesNumeris)) == false || kortelesNumeris <= 0) {
        alert("korteles numeris turi but sveikas teigiamas skaicius")
        return false;
    }
    if (isNaN(new Date(data).getTime())) {
        alert("invalid date korteles galiojimas")
        return false;
    }
    else
        return true;
}

function send() {
    //if (!validate())
    //   return false;

    var forma = document.forms["forma"];
    var vardas = forma["vardas"].value;
    var kortelesNumeris = forma["kortelesNumeris"].value;
    var data = forma["kortelesData"].value;

    $.ajax({
        url: "https://api.myjson.com/bins",
        type: "POST",
        data: '{"vardas":"{a}", "kortelesNumeris": "{b}", "data": "{c}"}'.supplant({a : vardas, b : kortelesNumeris, c : data}),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
            //alert(data.uri)
            $("p[name=uri]").html("{a}".supplant({ a: data.uri }))
        }
    });
}

function get() {
    $.ajax({
        url: $("p[name=uri]").text(),
        type: "Get",
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
            $("td[name=vardas]").html(data.vardas)
            $("td[name=numeris]").html(data.kortelesNumeris)
            $("td[name=data]").html(data.data)
        }
    });
}

$(document).ready(function () {

    $("button[name=innerhtml]").click(
        function () {
            $("p[name=innerhtml]").html("magic, wow")
        }
    )

    $("button[name=style]").click(
        function () {
            $("p[name=style]").css("fontSize", "50px");
        }
    )

    $("button[name=delete]").click(
        function () {
            $("p[name=delete]").remove()
        }
    )


    $("button[name=add]").click(
        function () {
            $("p[name=style]").append("<br>black magic fuckery<br>")
        }
    )
});

function onFormChange() {
    var vardas = $(":input[name=vardas]");
    if (vardas.val() == "asd")
        $("p").hide();
    else
        $("p").show();
}

String.prototype.supplant = function (o) {
    return this.replace(/{([^{}]*)}/g,
        function (a, b) {
            var r = o[b];
            return typeof r === 'string' || typeof r === 'number' ? r : a;
        }
    );
};
