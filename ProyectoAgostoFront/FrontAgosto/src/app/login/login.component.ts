import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"],
})
export class LoginComponent implements OnInit {
  form: FormGroup;
  constructor(private formBuilder: FormBuilder) {
    this.builForm();
  }

  ngOnInit(): void {}
  private builForm() {
    this.form = this.formBuilder.group({
      usuario: ["", [Validators.required]],
      contrasena: ["", [Validators.required]],
    });
  }
  enviarSesion() {
    if (this.form.valid) {
      console.log("EL FORMULARIO ESTA CORRECTO");
    } else {
      console.log("Formulario incorrecto");
    }
  }
}
