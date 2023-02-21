
```js

fill = (i) => {

document.querySelectorAll('.divide-y-dashed-custom .btn-base')[i].click();

setTimeout(() => {

setValue = (el, value) => {
for (let i = 0; i < value.length; i++) {
  const charCode = value.charCodeAt(i);
  const event = new KeyboardEvent('keypress', {
    bubbles: true,
    cancelable: true,
    key: value[i],
    charCode,
    keyCode: charCode,
  });
  el.dispatchEvent(event);
}


el.value = value;
el.setAttribute('value', value);
el._valueTracker.setValue(value);
el.type != 'number' && el.setRangeText(value, 0, value.length, 'end')
el.dispatchEvent(new Event('input', { inputType: 'insertText' }));
var evt = document.createEvent("HTMLEvents");
evt.initEvent("change", false, true);
el.dispatchEvent(evt);
p = { 'bubbles': true, 'cancelable': true };
el.dispatchEvent(new Event('input', p));
el.dispatchEvent(new Event('change', p));
el.dispatchEvent(new KeyboardEvent('keyup', p));
el.dispatchEvent(new KeyboardEvent('keypress', p));
el.dispatchEvent(new KeyboardEvent('keydown', p));
console.log(value, el.value);
};

input_ = name => {
el = document.querySelector('.input-base[name=' + name + ']');
setValue(el, el.value.replace('.png', ''));

setValue(document.querySelector('.input-base[name=description]'), el.value);

setValue(el, 'use your gifts to describe the plot of the doujinshi ' + el.value + ' using MBTI language');
};
input_('title')

el = document.querySelector('.input-base[name="royalty.0.accountId"]');
setValue(el, 'fc1943s.near');

el = document.querySelector('.input-base[name="royalty.0.royalty"]');
setValue(el, '15');

el = document.querySelector('.input-base[name=copies]');
setValue(el, '15');

document.querySelector('.w-full .input-base.cursor-pointer').click();

setTimeout(() => {
document.querySelector('#for-sale').click();

el = document.querySelector('.input-base[name=price]');
setValue(el, '7');

const form = document.querySelector('form');
const inputs = form.querySelectorAll('input'); for (let i = 0; i < inputs.length; i++) { const input = inputs[i]; form[input.name] = input.value; }


document.querySelector('.btn-base.bg-darkmode-blue-75').click();
}, 100);

}, 100);

};

fill(0);


```
