angular
    .module('app')
    .factory('dataservice', dataservice);

dataservice.$inject = ['$http', 'logger'];

function dataservice($http, logger) {

    var service = {
        getVehicle: getVehicle,
        getVehicleId: getVehicleId
    };
    return service;


    function getVehicle() {
        return $http.get('http://localhost:64407/api/vehicle')
            .then(getVehicleComplete)
            .catch(getVehicleError);
        function getVehicleComplete(response) {
            return response.data;
        }
        function getVehicleError(error) {
            logger.error('Error' + error.data);
        }
    }

    function getVehicleId(id) {
        var i = 1;
        return $http.get('http://localhost:64407/api/vehicle/' + id)
            .then(getVehicleComplete)
            .catch(getVehicleError);
        function getVehicleComplete(response) {
            return response.data;
        }
        function getVehicleError(error) {
            logger.error('Error' + error.data);
        }
    }
}



