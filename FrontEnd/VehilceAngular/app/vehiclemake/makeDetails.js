vehicleModule.controller('MakeDetailsController', function ($scope, $location, $http, $routeParams, $window) {

    $http.get('http://localhost:64407/api/vehicle/' + $routeParams.ID)

        .then(function (response) {
            $scope.ID = response.data.ID;
            $scope.Name = response.data.Name;
            $scope.Abrv = response.data.Abrv;
        });

    $scope.makeDelete =  function (xx) {

        $http.delete('http://localhost:64407/api/vehicle/' + $routeParams.ID)

            .then(function () {
                msg = "Item " + xx + " is Deleted!!!";
                $window.alert(msg);
                $location.path("vehicleMake");
            });        
    };

});



