"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").configureLogging(signalR.LogLevel.Information).build();

//Disable send button until connection is established

connection.on("ReceiveMessage", (user, message) => {
    var li = document.createElement("li");
    li.appendChild(
        document.createTextNode('${ user } : ${ message } '));
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});


connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", message);
    document.getElementById("messageInput").value = " "; 
    });
    event.preventDefault();
});