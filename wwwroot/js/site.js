// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

"use strict";

const connection = new signalR.HubConnectionBuilder().withUrl("/chat").build();

connection.on("ReceiveMessage", function (message) {
  console.log("ReceiveMessage", message);
  console.log(Turbo.session, Turbo.session.receiveMessageHTML);
  Turbo.renderStreamMessage(message);
});

connection.start();