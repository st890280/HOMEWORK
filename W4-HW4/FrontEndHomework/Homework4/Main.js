﻿$(document).ready(function () {
    var nickName = $("input[name=nickname]");
    var title = $("input[name=title]");
    var message = $("textarea[name=message]");

    $("#btn1").click(function () {
        var html =
            '<div style="border: 1px; solid black;"><p>NickName: ' +
            nickName.val() + "</p><p> Time: " +
            new Date().toISOString() + "</p><p> Title: " +
            title.val() + "</p><p> Message: " +
            message.val() + "</p></div>";

        $("#divContext").append(html);
    });
});