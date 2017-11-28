var app = angular.module('myApp', ['ngRoute']);

// configure our routes
app.config(function ($routeProvider) {
    $routeProvider

        // route for the FixedDeposit as default and first page
        .when('/', {
            templateUrl: 'Home.html',
            controller: 'Home'
        })

        // route for the FixedDeposit page
        .when('/About', {
            templateUrl: 'About.html',
            controller: 'About'
        })

        // route for the Loan page

         .when('/Home', {
             templateUrl: 'Home.html',
             controller: 'Home'
         })

        // route for the Recurring Deposit page
        .when('/RathoreDetail', {
            templateUrl: 'RathoreDetail.html',
            controller: 'RathoreDetail'
        })

         // route for the Recurring Deposit page
        .when('/Events', {
            templateUrl: 'Events.html',
            controller: 'Events'
        })

           // route for the Recurring Deposit page
        .when('/Places', {
            templateUrl: 'Places.html',
            controller: 'Places'
        })
          // route for the Recurring Deposit page
        .when('/Contact', {
            templateUrl: 'Contact.html',
            controller: 'Contact'
        })
          // route for the Recurring Deposit page
        .when('/Gallary', {
            templateUrl: 'Gallary.html',
            controller: 'Gallary'
        })
        .otherwise({
            redirectTo: '/',
            templateUrl: 'Home.html',
            controller: 'Home'
        });
});