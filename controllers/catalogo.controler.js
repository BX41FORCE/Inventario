var app = angular.module("Catalogo", [])
    .controller("CatalogoControlador", function ($scope) {
        $scope.codigo = "";
        $scope.tipo = "";
        $scope.categoria = "";
        $scope.descripcion = "";
    });