import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChangeThemeLangComponent  } from './change-theme-lang.component';

describe('ChangeThemeButtonComponent', () => {
  let component: ChangeThemeLangComponent ;
  let fixture: ComponentFixture<ChangeThemeLangComponent >;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ChangeThemeLangComponent ]
    });
    fixture = TestBed.createComponent(ChangeThemeLangComponent );
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
