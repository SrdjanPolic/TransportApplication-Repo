import { HttpClient, HttpEventType } from '@angular/common/http';
import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { environment } from './../../environments/environment';

@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css']
})
export class UploadComponent implements OnInit {
  public message: string;
  public progress: number;
  @Output() public onUploadFinished = new EventEmitter();

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  public uploadFile = (files) => {
    if (files.length === 0) {
      return;
    }
    const fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);
    const routeToLogin = 'api/' + 'Upload';
    this.http.post(this.createCompleteRoute(routeToLogin,environment.urlAddress), formData, { reportProgress: true, observe: 'events'})
    .subscribe( event => {
      if (event.type === HttpEventType.UploadProgress) {
        this.progress = Math.round(100 * event.loaded / event.total);
      } else if (event.type === HttpEventType.Response) {
        this.message = 'Upload završen.';
        this.onUploadFinished.emit(event.body);
      }
    });
  }
  private createCompleteRoute(route: string, envAddress: string) {
    return `${envAddress}/${route}`;
  }

}
