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