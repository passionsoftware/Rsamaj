// Controller for fixed deposit
app.controller('About', function ($scope) {
    // create a message to display in our view
    //$scope.inprinciple = 0;
    //$scope.inRateofInt = 0;
    //$scope.inTime = 0;

    $scope.Result = function () {
        P = $scope.inprinciple;
        r = $scope.inRateofInt;
        n = 4 //  number of times the interest is compounded per year
        t = $scope.inTime;
        var cal = Math.pow((1 + ((r / 100) / n)), (n * t));
        var result = P * cal;
        // var result = Math.pow(cal, power);
        return result;
    }
});