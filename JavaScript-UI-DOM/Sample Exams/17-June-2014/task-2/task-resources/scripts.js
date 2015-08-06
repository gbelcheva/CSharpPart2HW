/* globals $ */
$.fn.gallery = function (columns) {
    columns = columns || 4;

    var $this = $(this);
    var $selected = $this.children('.selected');
    var $galleryList = $this.children('.gallery-list');
    var $imageContainers = $galleryList.children('.image-container');
    var $currentImage = $selected.find('#current-image');
    var $previousImage = $selected.find('#previous-image');
    var $nextImage = $selected.find('#next-image');

    $nextImage.css('z', 205);
    $previousImage.css('z', 205);

    function getPrevIndex(index){
        var prevIndex = index - 1;
        return prevIndex < 1 ? $imageContainers.length : prevIndex;
    }

    function getNextIndex(index){
        var nextIndex = index + 1;
        return nextIndex > $imageContainers.length ? 1 : nextIndex;
    }

    function setPrevImage(index){
        var prevIndex = getPrevIndex(index);
        var prevSrc = $galleryList
            .find('[data-info=' + prevIndex + ']')
            .attr('src');
        var prevIndex = $galleryList
            .find('[data-info=' + prevIndex + ']')
            .data('info');

        setImage($previousImage, prevSrc, prevIndex);
    }

    function setNextImage(index){
        var nextIndex = getNextIndex(index);
        var nextSrc = $galleryList
            .find('[data-info=' + nextIndex + ']')
            .attr('src');
        var nextIndex = $galleryList
            .find('[data-info=' + nextIndex + ']')
            .data('info');

        setImage($nextImage, nextSrc, nextIndex);
    }

    function setCurImage(index){
        var curSrc = $galleryList
            .find('[data-info=' + index + ']')
            .attr('src');
        var curIndex = $galleryList
            .find('[data-info=' + index + ']')
            .data('info');

        setImage($currentImage, curSrc, curIndex);
    }

    function setImage($image, src, index){
        $image.attr('src', src);
        $image.attr('data-info', index);
    }


    $this.addClass('gallery');

    $selected.hide();

    $imageContainers.each(function(index, imageContainer){
        if (index % columns === 0) {
            $(imageContainer).addClass('clearfix');
        }
    });

    $galleryList.on('click', 'img', function(){
        $selected.show();
        $('<div />').addClass('disabled-background').appendTo($this);
        var $target = $(this);
        var targetIndex = $target.data('info');
        var index = parseInt(targetIndex);

        setNextImage(index);
        setCurImage(index);
        setPrevImage(index);

        $galleryList.addClass('blurred');

    });

    $currentImage.on('click', function(){
        $selected.hide();
        $this.find('.disabled-background').remove();
        $galleryList.removeClass('blurred');
        $this.removeClass('disabled-background');

    });

    $previousImage.on('click', function(){
        var $target = $(this);
        var index = parseInt($target.attr('data-info'));

        setNextImage(index);
        setCurImage(index);
        setPrevImage(index);

    });

    $nextImage.on('click', function(){
        var $target = $(this);
        var index = parseInt($target.attr('data-info'));

        setNextImage(index);
        setCurImage(index);
        setPrevImage(index);
    });

    return this;
};