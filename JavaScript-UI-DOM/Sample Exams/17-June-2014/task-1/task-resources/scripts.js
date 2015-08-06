function createImagesPreviewer(selector, items){
    var root = document.querySelector(selector);
    var fragment = document.createDocumentFragment();

    var imagePreviewer = document.createElement('div');
    imagePreviewer.style.display = 'inline block';
    imagePreviewer.style.width = '70%';
    imagePreviewer.style.float = 'left';
    imagePreviewer.style.textAlign = 'center';


    var selectedParent = document.createElement('div');
    selectedParent.className = 'image-preview';
    var selectedImageHeader = document.createElement('h3');
    selectedImageHeader.innerHTML = items[0].title;
    var selectedImage = document.createElement('img');
    selectedImage.src = items[0].url;
    selectedImage.style.width = '80%';

    selectedParent.appendChild(selectedImageHeader);
    selectedParent.appendChild(selectedImage);
    imagePreviewer.appendChild(selectedParent);

    var aside = document.createElement('div');
    aside.style.display = 'inline block';
    aside.style.width = '20%';
    aside.style.float = 'left';
    aside.style.textAlign = 'center';


    var input = document.createElement('input');
    input.id = 'filter';
    var inputLabel = document.createElement('label');
    inputLabel.innerHTML = 'Filter';
    inputLabel.setAttribute('for', 'filter');
    aside.appendChild(inputLabel);
    aside.appendChild(input);

    input.addEventListener('keyup', function(ev){
        var pattern = ev.target.value;

        var liChildren = listOfItems.getElementsByTagName('li');

        var j, len;
        for (j = 0, len = liChildren.length; j < len; j += 1) {
            var currentLi = liChildren[j];
            var header = currentLi.firstElementChild.innerHTML;

            if (header.toLocaleLowerCase().indexOf(pattern.toLowerCase()) < 0) {
                currentLi.style.display = 'none';
            } else {
                currentLi.style.display = 'block';
            }
        }

    }, false);



    var listOfItems = document.createElement('ul');
    listOfItems.style.listStyleType = 'none';
    listOfItems.style.height = '400px';
    listOfItems.style.overflowY = 'scroll';
    listOfItems.addEventListener('click', function(ev){
        var target = ev.target;

        if (target.tagName.toLowerCase() === 'img') {
            var header = target.previousElementSibling.innerHTML;
            var src = target.src;
            selectedImageHeader.innerHTML = header;
            selectedImage.src = src;
        }

        if (target.tagName.toLowerCase() === 'h3') {
            var header = target.innerHTML;
            var src = target.nextElementSibling.src;
            selectedImageHeader.innerHTML = header;
            selectedImage.src = src;
        }
    }, false);

    listOfItems.addEventListener('mouseover', function(ev){
        var target = ev.target;

        if (target.tagName.toLowerCase() === 'img') {
            target.parentElement.style.background = 'grey';
            target.parentElement.style.cursor = 'pointer';
        }
    }, false);

    listOfItems.addEventListener('mouseout', function(ev){
        var target = ev.target;

        if (target.tagName.toLowerCase() === 'img') {
            target.parentElement.style.background = '';
        }
    }, false);

    var li = document.createElement('li');
    li.className = 'image-container';
    var imageHeader = document.createElement('h3');
    var image = document.createElement('img');

    var i, len;
    for (i = 0, len = items.length; i < len; i += 1) {
        var currentItem = items[i];
        var currentLi = li.cloneNode(true);
        var currentImageHeader = imageHeader.cloneNode(true);
        var currentImage = image.cloneNode(true);

        currentImageHeader.innerHTML = currentItem.title;
        currentImage.src = currentItem.url;
        currentImage.style.width = '90%';


        currentLi.appendChild(currentImageHeader);
        currentLi.appendChild(currentImage);
        listOfItems.appendChild(currentLi);
    }

    aside.appendChild(listOfItems);

    fragment.appendChild(imagePreviewer);
    fragment.appendChild(aside);

    root.appendChild(fragment);
    var body = document.getElementsByTagName('body');
    body.appendChild(root);
}




//function createImagesPreviewer(selector, items) {
//  var root = document.querySelector(selector);
//  root.className += ' image-previewer';
//
//  var table = document.createElement('table');
//  table.style.height = '400px';
//  table.style.overflow = 'hidden';
//
//  var theRow = document.createElement('tr');
//  table.appendChild(theRow);
//  root.appendChild(table);
//
//  /* Left panel */
//  var leftPanel = document.createElement('td');
//  leftPanel.className += ' left-panel';
//
//  var title = document.createElement('h1');
//  title.innerHTML = items[0].title;
//
//  var bigImage = document.createElement('img');
//  bigImage.src = items[0].url;
//
//  leftPanel.appendChild(title);
//  leftPanel.appendChild(bigImage);
//  /* End of left panel */
//
//  /* Right panel */
//  var rightPanel = document.createElement('td');
//  rightPanel.className += ' right-panel';
//  rightPanel.style.textAlign = 'center';
//  rightPanel.style.overflowY = 'scroll';
//
//  var filter = document.createElement('div');
//  filter.className = 'filter';
//  var filterTitle = document.createElement('span');
//  filterTitle.innerHTML = 'Filter';
//  var filterBox = document.createElement('input');
//  filterBox.type = 'text';
//  filter.appendChild(filterTitle);
//  filter.appendChild(document.createElement('br'));
//  filter.appendChild(filterBox);
//
//  rightPanel.appendChild(filter);
//
//  var imgsList = document.createElement('ul');
//  imgsList.style.listStyleType = 'none';
//  imgsList.style.height = '200px';
//  for (var i = 0; i < items.length; i += 1) {
//
//    var imgItem = document.createElement('li');
//    imgItem.setAttribute('data-index', i + '');
//    imgItem.style.width = '150px';
//
//    var imgItemTitle = document.createElement('span');
//    imgItemTitle.innerHTML = items[i].title;
//    imgItem.appendChild(imgItemTitle);
//
//    var imgItemImg = document.createElement('img');
//    imgItemImg.src = items[i].url;
//    imgItemImg.style.maxWidth = '100%';
//
//    imgItem.appendChild(imgItemImg);
//    imgsList.appendChild(imgItem);
//  }
//
//  rightPanel.appendChild(imgsList);
//
//  /* End of right panel */
//
//
//  theRow.appendChild(leftPanel);
//  theRow.appendChild(rightPanel);
//}