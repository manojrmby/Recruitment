$(document).ready(function () {
	loadData();
});

function loadData() {

	$.ajax({
		url: "/admin/RoleList",
		type: "GET",
		contentType: "application/json;charset=utf-8",
		dataType: "json",
		cache: false,
		async: true,
		success: function (result) {
			debugger;
			var html = '';
			$.each(result, function (key, item) {
				html += '<tr>';
				html += '<td style="display:none;">' + item.ID + '</td>';
				html += '<td>' + item.EmployeeID + '</td>';
				html += '<td>' + item.Name + '</td>';
				html += '<td>' + item.Age + '</td>';
				html += '<td>' + item.State + '</td>';
				html += '<td>' + item.Country + '</td>';
				html += '<td><a href="#" onclick="return getbyID(' + item.ID + ')">Edit</a> | <a href="#" onclick="Delele(' + item.ID + ')">Delete</a></td>';
				html += '</tr>';
			});
			$('.tbody').html(html);
		},
		error: function (errormessage) {
			alert(errormessage.responseText);
		}
	});
}