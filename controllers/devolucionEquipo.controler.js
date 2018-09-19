var app = angular.module("Devolucion", [])
    .controller("DevolucionControlador", function ($scope) {
        $scope.tipo = "";
        $scope.codigo = "";
        $scope.asignado = "";
        $scope.aprobado = "";
    });