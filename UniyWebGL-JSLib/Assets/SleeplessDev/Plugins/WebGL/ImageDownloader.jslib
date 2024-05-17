// ImageDownloaderPlugin.jslib
mergeInto(LibraryManager.library, {
    ImageDownloader: function(url, fn) {
        var imageUrl = UTF8ToString(url);
        var fileName = UTF8ToString(fn);

        fetch(imageUrl)
            .then(response => response.blob())
            .then(blob => {
                var reader = new FileReader();
                reader.onloadend = function() {
                    var base64data = reader.result.split(',')[1]; // Get the base64 part
                    var contentType = 'image/jpeg';

                    function fixBinary(bin) {
                        var length = bin.length;
                        var buf = new ArrayBuffer(length);
                        var arr = new Uint8Array(buf);
                        for (var i = 0; i < length; i++) {
                            arr[i] = bin.charCodeAt(i);
                        }
                        return buf;
                    }

                    var binary = fixBinary(atob(base64data));
                    var data = new Blob([binary], {type: contentType});
                    var link = document.createElement('a');
                    link.download = fileName;
                    link.href = window.URL.createObjectURL(data);
                    link.click();
                };
                reader.readAsDataURL(blob);
            })
            .catch(error => console.error('Error downloading image:', error));
    }
});
