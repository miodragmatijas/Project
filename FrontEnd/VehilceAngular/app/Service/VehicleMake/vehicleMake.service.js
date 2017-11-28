angular
    .module('app')
    .factory('dataservice', dataservice);

dataservice.$inject = ['$http', 'logger'];

function dataservice($http, logger) {

    var service = {
        getVehicle: getVehicle,
        getVehicleId: getVehicleId,
        deleteVehicleId: deleteVehicleId
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

    function deleteVehicleId(id) {
        return $http.delete('http://localhost:64407/api/vehicle/' + id)
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



