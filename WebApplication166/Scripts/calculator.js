function calculate(a, b, action) {
    $.ajax({
        url: "/api/Calculator/Calculate",
        method: "POST",
        data: {
            DigA: a,
            DigB: b,
            Action: action
        },
        success: function (result) {
            $("#result").text(result.Result);
        },
        fail: function () {
            alert("Ошибка");
        }
    });
}

function init() {
    $(".action").click(function () {
        calculate($("#digA").val(), $("#digB").val(), $(this).text());
    });
}