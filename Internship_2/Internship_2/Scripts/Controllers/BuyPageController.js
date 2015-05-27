var BuyPageController = function ($scope,$location) {
   
    $scope.GetCities = 
        
                    [{ "Value":1, "Text":"Bangalore"},
                     {"Value":2, "Text":"Chennai"},
                     {"Value":3, "Text":"HyderaBad"},
                     { "Value": 4, "Text": "Mumbai" }]

    $scope.GetBudgetRanges =
                    
                    [{ "Value": 1, "Text": "0 - 1L" },
                     { "Value": 2, "Text": "1L - 10L"},
                     { "Value": 3, "Text": "10L - 20L" },
                     { "Value": 4, "Text": "20L Above" }]


    $scope.GetYearRanges =

                   [{ "Value": 1, "Text": "0 - 2 yrs" },
                    { "Value": 2, "Text": "2 yrs - 5 yrs" },
                    { "Value": 3, "Text": "5 yrs - 10 yrs" },
                    { "Value": 4, "Text": "10 yrs Above" }]


    $scope.GetMakes =

                    [{ "Value": 1, "Text": "Maruti" },
                     { "Value": 2, "Text": "Hyundai" },
                     { "Value": 3, "Text": "Ford" },
                     { "Value": 4, "Text": "Honda" }]

    $scope.GetColors =

                   [{ "Value": 1, "Text": "Blue" },
                    { "Value": 2, "Text": "Red" },
                    { "Value": 3, "Text": "Gray" },
                    { "Value": 4, "Text": "Orange" }]

    $scope.GetKMRanges =

                  [{ "Value": 1, "Text": "0 - 10,000 km" },
                   { "Value": 2, "Text": "10,000 - 50,000 km" },
                   { "Value": 3, "Text": "50,000 - 1L km" },
                   { "Value": 4, "Text": "1L km above" }]




    $scope.currentCity = GetCitites[0].Text;
    $scope.currentBudgetRange = GetBudgetRanges[0].Text;
    $scope.currentYearRange = GetYearRanges[0].Text;
    $scope.currentMake = GetMakes[0].Text;
    $scope.currentColor = GetColors[0].Text;
    $scope.currentKMRange = GetKMRanges[0].Text;

    $scope.changeView = function (view) {

        $location.url(view);
    }


    };


// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
BuyPageController.$inject = ['$scope','$location'];