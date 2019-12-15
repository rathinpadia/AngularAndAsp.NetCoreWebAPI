import { TrainingDetail } from './training-detail.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class TrainingDetailService {
  formData: TrainingDetail
  readonly rootURL= "http://localhost:64722/api";

  constructor(private http:HttpClient) { }

  postTrainingDetail() {
    return this.http.post(this.rootURL + '/Training', this.formData);
  }
  
}
