﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
showPopUp = (url, title) => {
    $.ajax({
        type: 'GET',
        url: url,
        success: function (res) {
            $("#addNewModal .modal-body").html(res);
            $("#addNewModal .modal-title").html(title);
            $("#addNewModal").modal('show');
        }
    })
};