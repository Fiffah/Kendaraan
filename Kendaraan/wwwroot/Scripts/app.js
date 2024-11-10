document.getElementById('vehicleForm').addEventListener('submit', function(event) {
    const tahun = document.querySelector('[name="TahunPembuatan"]').value;
    if (tahun.length !== 4) {
        alert('Tahun Pembuatan harus terdiri dari 4 digit.');
        event.preventDefault();
    }
});
