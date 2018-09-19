var app = angular.module("BajaEquipo", [])
    .controller("BajaControlador", function ($scope) {
        $scope.codigo = "";
        $scope.asignado = "";
        $scope.aprobado = "";
    });