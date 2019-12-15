import { TrainingDetailService } from './shared/training-detail.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { TrainingDetailsComponent } from './training-details/training-details.component';
import { TrainingDetailComponent } from './training-details/training-detail/training-detail.component';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';


@NgModule({
  declarations: [
    AppComponent,
    TrainingDetailsComponent,
    TrainingDetailComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot(), BsDatepickerModule.forRoot(), // ToastrModule added
  ],
  providers: [TrainingDetailService],
  bootstrap: [AppComponent]
})
export class AppModule { }
