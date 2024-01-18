const arrivalDate = document.getElementById('arrivalDate');

document.getElementById('cbx').addEventListener('change', function () {
    if (this.checked) {
        arrivalDate.style.display = 'none';
        arrivalDate.value = null;
    }
    else {
        arrivalDate.style.display = 'inline-block';
    }
});