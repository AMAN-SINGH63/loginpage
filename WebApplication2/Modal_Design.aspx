<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modal_Design.aspx.cs" Inherits="WebApplication2.Modal_Design" %>

<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        /* The Modal (background) */
        .modal {
            display: none;
            position: fixed;
            z-index: 1;
            left: 0;
            top: 0;
            width: 100%;
            height: 100%;
            overflow: auto;
            background-color: rgb(0, 0, 0);
            background-color: rgba(0, 0, 0, 0.4);
            animation-name: fadeIn;
            animation-duration: 0.4s;
        }

        /* Modal Content */
        .modal-content {
            position: fixed;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            background-color: #fefefe;
            width: 80%; /* You can adjust this width as needed */
            max-width: 800px; /* You can adjust this maximum width as needed */
            animation-name: slideIn;
            animation-duration: 0.4s;
        }

        /* The Close Button */
        .close {
            color: white;
            float: right;
            font-size: 28px;
            font-weight: bold;
        }

            .close:hover,
            .close:focus {
                color: #000;
                text-decoration: none;
                cursor: pointer;
            }

        .modal-header {
            padding: 2px 16px;
            background-color: red;
            color: white;
        }

        .modal-body {
            padding: 2px 16px;
        }

        .modal-footer {
            padding: 2px 16px;
            background-color: red;
            color: white;
        }

        /* Add Animation */
        @keyframes slideIn {
            from {
                bottom: -300px;
                opacity: 0;
            }

            to {
                bottom: 0;
                opacity: 1;
            }
        }

        @keyframes fadeIn {
            from {
                opacity: 0;
            }

            to {
                opacity: 1;
            }
        }
    </style>
</head>
<body>

    <script src="js/jquery.min.js"></script>
    <script src="js/modal.js"></script>
    <h2>Bottom modal</h2>

    <button id="myBtn">open modal</button>

    <div id="myModal" class="modal">

        <div class="modal-content">

            <div class="modal-header">

                <span class="close">&times;</span>

                <h2>SUNWODA</h2>

            </div>
            <div class="modal-body">

                <div id="showingta"></div>

            </div>


            <div class="modal-footer">
                <h3>TOTAL RECORD</h3>
                <label id="footertotal"></label>

            </div>

        </div>

    </div>

    
</body>
</html>
