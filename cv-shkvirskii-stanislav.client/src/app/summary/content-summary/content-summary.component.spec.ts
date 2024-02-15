import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContentSummaryComponent } from './content-summary.component';

describe('ContentSummaryComponent', () => {
  let component: ContentSummaryComponent;
  let fixture: ComponentFixture<ContentSummaryComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ContentSummaryComponent]
    });
    fixture = TestBed.createComponent(ContentSummaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
