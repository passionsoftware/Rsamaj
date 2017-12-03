$(document).ready(function () {
    $("#CurrentCountryName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../RathoreDetails/CountryAutosuggest",
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
                url: "../RathoreDetails/StateAutosuggest",
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
                url: "../RathoreDetails/DistrictAutosuggest",
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
                url: "../RathoreDetails/LocationAutosuggest",
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
                url: "../RathoreDetails/CountryAutosuggest",
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
                url: "../RathoreDetails/StateAutosuggest",
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
                url: "../RathoreDetails/DistrictAutosuggest",
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
                url: "../RathoreDetails/LocationAutosuggest",
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


