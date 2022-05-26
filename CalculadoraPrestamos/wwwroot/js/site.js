// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//codigo para cambiar el texto del campo interes dependiendo el tipo de prestamo.

    const llenarInteres = () =>
    {
        let index = document.getElementById("TipoPrestamo").value;
        let interes = document.getElementById("interes");

        if (index == 1) {
            interes.value = "22"
        }
        else if (index == 2) {
            interes.value = "12"
        }
        else if (index == 3) {
            interes.value = "8"
        }
    }

