import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CenterComponent } from "./pages/components/center/center.component";
import { DashboardComponent } from "./pages/components/dashboard/dashboard.component";
import { Prueba1Component } from "./pages/components/prueba1/prueba1.component";
import { Prueba2Component } from "./pages/components/prueba2/prueba2.component";
import { LoginComponent } from "./login/login.component";
import { PagesComponent } from "./pages/pages.component";

const routes: Routes = [
  {
    path: "",
    component: PagesComponent,
    children: [
      { path: "center", component: CenterComponent },
      { path: "dashboard", component: DashboardComponent },
      { path: "prueba1", component: Prueba1Component },
      { path: "prueba2", component: Prueba2Component },

    ],
  },
  { path: "login", component: LoginComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
