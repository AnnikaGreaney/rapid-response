user = User.where(name: "User", email: "annikagreaney@gmail.com").first_or_initialize
if user.new_record?
  user.password = "password123"
  user.password_confirmation = "password123"
  user.save
end
