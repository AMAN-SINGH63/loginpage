<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logic.aspx.cs" Inherits="WebApplication2.logic" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html>
<head>
    <title>Calculate Average</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>
<body>
    <h1>Calculate Average</h1>
    <button id="calculateButton">Calculate Average</button>
    <div id="result"></div>

    <script>
        // Function to calculate the average of an array of numbers
        function calculateAverage(numbers) {
            if (numbers.length === 0) {
                return 0; // Handle the case of an empty array
            }
            const total = numbers.reduce((acc, num) => acc + num, 0);
            return total / numbers.length;
        }

        // Function to make an AJAX request to fetch the list of numbers
        function fetchNumbersAndCalculateAverage() {
            $.ajax({
                url: 'your_server_endpoint_here', // Replace with your server endpoint
                method: 'GET',
                dataType: 'json',
                success: function (data) {
                    const numbers = data.numbers; // Assuming the response contains an array of numbers
                    const average = calculateAverage(numbers);
                    $('#result').html(`The average is: ${average}`);
                },
                error: function () {
                    $('#result').html('Error fetching data from the server.');
                }
            });
        }

        // Attach an event listener to the button to trigger the AJAX request
        $(document).ready(function () {
            $('#calculateButton').click(function () {
                fetchNumbersAndCalculateAverage();
            });
        });
    </script>
</body>
</html>


