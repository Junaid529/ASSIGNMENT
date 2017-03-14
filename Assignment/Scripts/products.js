$(document).ready(function () {
    getProducts();
});
function getProducts() {
    $.ajax({
        url: '/Orders/GetAll/',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var rows = '';
            $.each(data, function (i, item) {
                rows += "<tr>"
                rows += "<td>" + item.COUNTRY_NAME + "</td>"
                //rows += "<td><a onclick='return detailsById(" + item.job_id + ")'>" + item.job_desc + "</a></td>"
                rows += "<td>" + item.TypeOfDocument + "</td>"
                rows += "<td>" + item.Urgency + "</td>"
                //rows += "<td><button type='button' id='btnEdit' class='btn btn-default' onclick='return getProductById(" + item.job_id + ")'>Edit</button> <button type='button' id='btnDelete' class='btn btn-danger' onclick='return deleteProductById(" + item.job_id + ")'>Delete</button></td>"
                rows += "</tr>";
                $("#listProducts tbody").html(rows);
            });
        },
        error: function (err) {
            alert("Error: " + err.responseText);
        }
    });
}