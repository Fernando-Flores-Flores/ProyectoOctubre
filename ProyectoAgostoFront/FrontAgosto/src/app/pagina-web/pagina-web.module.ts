import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { PaginaComponent } from "./pagina/pagina.component";
import { HeaderComponent } from "./pagina/shared/header/header.component";
import { PaginaWebRoutingModule } from "./pagina-web-routing-module";

@NgModule({
  declarations: [PaginaComponent, HeaderComponent],
  imports: [CommonModule, PaginaWebRoutingModule],
  exports: [PaginaComponent],
})
export class PaginaWebModule {}
