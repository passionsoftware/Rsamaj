$(document).ready(function () {
    google.charts.load('current', { packages: ["orgchart"] });
    google.charts.setOnLoadCallback(drawChart);
    //drawEmpChart();
});


function drawChart() {
    debugger;
    $.ajax({
        type: "GET",
        url: "../GetHierarchicalDetail",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (empData) {

            var chartData = new google.visualization.DataTable();

            chartData.addColumn('string', 'Name');
            chartData.addColumn('string', 'Manager');
            chartData.addColumn('string', 'ToolTip');

            $.each(empData, function (index, row) {
                var ParentId = String(row.ParentId) == '-1' ? '' : row.ParentId;
                debugger;
                var Name = row.Age == undefined ? '<b style="font-size:14px">' + row.Name + '</b>' : '<b style="font-size:14px">' + row.Name + ' (' + row.Age + ')</b>';
                var SpouseName = row.SpouseName == undefined ? '<div style="color:red">(Unmarried)</div>' : '<div>(<span style="color:red">' + row.SpouseName + '</span>)</div>';

                chartData.addRows([[{
                    v: String(row.RathoreDetailId),
                    f: Name + SpouseName
                }, String(ParentId), (row.Location + ", " + row.District)]]);
            });

            var chart = new google.visualization.OrgChart($("#chart_div")[0]);
            chart.draw(chartData, { allowHtml: true });
        },
        failure: function (xhr, status, error) {
            alert("Failure: " + xhr.responseText);
        },
        error: function (xhr, status, error) {
            alert("Error: " + xhr.responseText);
        }
    });
}