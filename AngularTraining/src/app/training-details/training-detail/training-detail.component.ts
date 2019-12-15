import { TrainingDetail } from './../../shared/training-detail.model';
import { NgForm } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { TrainingDetailService } from 'src/app/shared/training-detail.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-training-detail',
  templateUrl: './training-detail.component.html',
  styleUrls: ['./training-detail.component.css']
})
export class TrainingDetailComponent implements OnInit {

  constructor(private service:TrainingDetailService, private toastr: ToastrService) { }
  error:any={isError:false,errorMessage:''};
  isValidDate:any;

  ngOnInit() {
    this.resetForm();
    

  }
 resetForm(form? :NgForm){

   if(form != null)
  form.resetForm();

  this.service.formData = {
    TrainingId:0,
    TrainingName:"",
    StartDate:null,
    EndDate:null
  }
 }

 onSubmit(form:NgForm){
  var startdate = form.value.StartDate;
  var endDate = form.value.EndDate;

  this.isValidDate = this.validateDates(startdate, endDate);
  if(this.isValidDate){
    var dayDiffInDays = this.getDateDifference(startdate,endDate);
   this.service.postTrainingDetail().subscribe(
     res => {
       this.resetForm(form);
       this.toastr.success("Training Saved Successfully, Date difference Start Date and End Date is " + dayDiffInDays,"")
     },
     err => {
       console.log(err);
     }
   )
 }
}

 validateDates(sDate: string, eDate: string){
  this.isValidDate = true;

  if((sDate != null && eDate !=null) && (eDate) < (sDate)){
    this.error={isError:true,errorMessage:'End date should be greater than Start date.'};
    this.isValidDate = false;
  }
  return this.isValidDate;
}

getDateDifference(sDate: string, eDate:string){
  var date2 = new Date(sDate);
  var date1 = new Date(eDate);
  var timeDiff = Math.abs(date2.getTime() - date1.getTime());
  var dayDifference = Math.ceil(timeDiff / (1000 * 3600 * 24));
  return dayDifference;
}


}
