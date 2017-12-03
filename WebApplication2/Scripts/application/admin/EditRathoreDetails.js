$(document).ready(function () {
    $("#CurrentCountryName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../CountryAutosuggest",
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


    $("#CurrentStateName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../StateAutosuggest",
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

    $("#CurrentDistrictName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../DistrictAutosuggest",
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


    $("#CurrentLocationName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../LocationAutosuggest",
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


    $("#NativeCountryName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../CountryAutosuggest",
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


    $("#NativeStateName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../StateAutosuggest",
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

    $("#NativeDistrictName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../DistrictAutosuggest",
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


    $("#NativeLocationName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../LocationAutosuggest",
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


