$(document).ready(function () {
    $("#DistrictName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../Events/DistrictAutosuggest",
                type: "POST",
                dataType: "json",
                data: { Prefix: request.term },
                success: function (data) {
                   
                    response($.map(data, function (item) {
                         return { label: item.Value, value: item.Value };
                    }))

                }
            })
        },
        messages: {
            noResults: "", results: ""
        }
    });


    $("#LocationName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../Events/LocationAutosuggest",
                type: "POST",
                dataType: "json",
                data: { Prefix: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.Value, value: item.Value };
                    }))

                }
            })
        },
        messages: {
            noResults: "", results: ""
        }
    });

    $("#EventTypeName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../Events/EventAutosuggest",
                type: "POST",
                dataType: "json",
                data: { Prefix: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.Value, value: item.Value };
                    }))

                }
            })
        },
        messages: {
            noResults: "", results: ""
        }
    });

})


