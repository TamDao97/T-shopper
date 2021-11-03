$(document).ready(() => {
  function download() {
    $.ajax({
      url: "https://localhost:44326/product/download-file",
      method: "POST",
      success: function (res) {
        console.log('success');
      }, error: function (error) {

      }
    });
  }

  download();
});
