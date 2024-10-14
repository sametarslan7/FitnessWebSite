$(document).ready(function () {
    // İlk class gösterilecek, diğerleri gizlenecek
    $('.class-content').hide();  // Tüm class içeriklerini gizliyoruz
    $('.class-content').first().show();  // İlkini gösteriyoruz

    // Class isimlerine tıklama olayını yönetiyoruz
    $('.tab-link').click(function () {
        var classId = $(this).data('id');  // Tıklanan class'ın ID'sini alıyoruz

        // Tüm içerikleri gizle
        $('.class-content').hide();

        // Sadece tıklanan class'ın içeriğini göster
        $('#class-content-' + classId).show();
    });
});
