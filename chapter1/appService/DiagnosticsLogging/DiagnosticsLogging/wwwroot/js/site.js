// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var exThrowBtn;
var logWarnBtn;
var logWarnBtn;
var logInfoBtn;
var msgInput;

$(function () {
    exThrowBtn = $("#exThrowBtn");
    logErrBtn = $("#logErrBtn");
    logWarnBtn = $("#logWarnBtn");
    logInfoBtn = $("#logInfoBtn");
    msgInput = $("#messageInput");

    exThrowBtn.on("click", function () { sendRequest("/exception", msgInput[0].value) });
    logErrBtn.on("click", function () { sendRequest("/logError", msgInput[0].value) });
    logWarnBtn.on("click", function () { sendRequest("/logWarning", msgInput[0].value) });
    logInfoBtn.on("click", function () { sendRequest("/logInfo", msgInput[0].value) });
});

function sendRequest(url, message) {
    $.ajax({
        type: "POST",
        url: url,
        data: { logMessage: message }
    });
};