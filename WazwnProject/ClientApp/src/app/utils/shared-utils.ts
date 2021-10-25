import { Injectable } from "@angular/core";

@Injectable({ providedIn: "root" })

export class SharedUtils {
  constructor() { }
  isNumber(evt) {
    var iKeyCode = evt.which ? evt.which : evt.keyCode;
    return !(
      iKeyCode != 46 &&
      iKeyCode > 31 &&
      (iKeyCode < 48 || iKeyCode > 57)
    );
  }
  isAlphabet(evt) {
    var keyCode = evt.keyCode || evt.which;
    var regex = new RegExp("^[a-zA-Z ]+$");
    return regex.test(String.fromCharCode(keyCode));
  }
}
