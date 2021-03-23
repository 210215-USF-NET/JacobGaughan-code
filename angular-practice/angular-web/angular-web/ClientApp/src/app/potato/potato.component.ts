import { Component, ViewChild, ElementRef } from '@angular/core';

@Component({
  selector: 'app-potato-component',
  templateUrl: './potato.component.html'
})
export class PotatoComponent {
  @ViewChild('potatosection', { static: false }) potatosection: ElementRef;
  public currentPotatoes = 0;
  public potatoFile = "../potato.png";
  public zIndex = 10;

  public setAttributes(el, options) {
  Object.keys(options).forEach(function (attr) {
    el.setAttribute(attr, options[attr]);
  })
}

  public incrementCounter() {
    this.currentPotatoes++;
    this.zIndex++;

    let size = Math.floor(Math.random() * (400 - 40 + 1)) + 40;
    let positionX = Math.floor(Math.random() * (100 + 1));
    let positionY = Math.floor(Math.random() * (100 + 1));
    let rotationAngle = Math.floor(Math.random() * (360 + 1));

    var newPotato = document.createElement("img");
    this.setAttributes(newPotato, { "src": this.potatoFile, "width": size, "height": size, "style": `position: absolute; left: ${positionX}%; bottom: ${positionY}%; transform: rotate(${rotationAngle}deg); z-index: ${this.zIndex};` })

    this.potatosection.nativeElement.appendChild(newPotato);
    console.log(this.currentPotatoes);

  }
}
