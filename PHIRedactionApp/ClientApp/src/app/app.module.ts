// app.module.ts
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { FileUploadService } from '../services/file-upload.service';

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    HttpClientModule, // Import HttpClientModule here
  ],
  providers: [FileUploadService],
  bootstrap: [AppComponent],
})
export class AppModule {}
