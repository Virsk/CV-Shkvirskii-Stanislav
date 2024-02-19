import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkSpaseComponent } from './work-spase.component';

describe('WorkSpaseComponent', () => {
  let component: WorkSpaseComponent;
  let fixture: ComponentFixture<WorkSpaseComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [WorkSpaseComponent]
    });
    fixture = TestBed.createComponent(WorkSpaseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
