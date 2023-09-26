"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

// Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;

function scrollToBottom() {
    var messagesList = document.getElementById("messagesList");
    messagesList.scrollTop = messagesList.scrollHeight;
}

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("p");
    var homeUser = document.getElementById("userInput").value;
    var messagesList = document.getElementById("messagesList");

    if (user !== homeUser) {
        li.innerHTML = `<strong>${user}</strong> <br> ${message}`;
        li.className = "home-message";
    } else {
        li.innerHTML = `${message}`;
        li.className = "incoming-message";
    }

    messagesList.appendChild(li);
    scrollToBottom(); // Scroll to the bottom when a new message is received
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
    document.getElementById("messageInput").value = "";
});
