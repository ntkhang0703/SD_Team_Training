import { NgModule } from "@angular/core";
import { SumPipe } from "./sum.pipe";
import { SumAttrPipe } from "./sumAttr.pipe";


@NgModule({
  declarations: [
    SumPipe,
    SumAttrPipe,
  ],
  exports: [SumPipe, SumAttrPipe],
})
export class AppPipeModule {}
