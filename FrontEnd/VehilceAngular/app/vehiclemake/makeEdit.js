﻿vehicleModule.controller('MakeEditController', function ($scope, $routeParams, $http) {

    $http.get('http://localhost:64407/api/vehicle/' + $routeParams.ID)

        .then(function (response) {
            $scope.ID = response.data.ID;
            $scope.Name = response.data.Name;
            $scope.Abrv = response.data.Abrv;

        });

});