var BuyPageApp = angular.module('BuyPageApp', []);

BuyPageApp.controller('BuyPageController', BuyPageController);

var configFunction = function ($routeProvider) {
    $routeProvider.
        when('/CityFilter', {
            templateUrl: 'Buy/CityFilter'
        })
        .when('/BudgetRangeFilter', {
            templateUrl: 'Buy/BudgetRangeFilter'
        })
        .when('/YearRangeFilter', {
            templateUrl: 'Buy/YearRangeFilter'
        })
        .when('/MakeFilter', {
            templateUrl: 'Buy/MakeFilter'
         })
        .when('/ColorFilter', {
            templateUrl: 'Buy/ColorFilter'
        })
        .when('/KMRangeFilter', {
            templateUrl: 'Buy/KMRangeFilter'
        });
}
configFunction.$inject = ['$routeProvider'];

BuyPageApp.config(configFunction);