angular
    .module('app')
    .controller('MakeEditController', MakeEditController);

function MakeEditController($scope, $routeParams, $http, $window) {

    $http.get('http://localhost:64407/api/vehicle/' + $routeParams.ID)

        .then(function (response) {
            $scope.ID = response.data.ID;
            $scope.Name = response.data.Name;
            $scope.Abrv = response.data.Abrv;

            $scope.update = function () {
                var obj = {
                    ID: response.data.ID,
                    Name: response.data.Name,
                    Abrv: response.data.Abrv
                };

                $http.put('http://localhost:64407/api/vehicle/', obj).success(function (data) {

                    $windwow.alert("Success Updated!!!");

                }).error(function (data) {
                    $window.alert("Error! " + data.Message);
                });
            };

        });
}