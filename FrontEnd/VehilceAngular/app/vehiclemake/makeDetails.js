vehicleModule.controller('MakeDetailsController', function ($scope,$location,$http) {

    $scope.detailsVehicle =  async function (dat) {

       await $http.get('http://localhost:64407/api/vehicle/' + dat)

            .then(function (response) { $scope.Vehicle = response.data; });

       $scope.detailsVehicle.Vehicle.ID = $scope.Vehicle.ID;
        var ai ="";
        

        
    };
    //$location.path('/MakeDetails');
});
   


